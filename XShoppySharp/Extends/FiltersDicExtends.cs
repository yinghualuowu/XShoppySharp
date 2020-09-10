using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace XShoppySharp.Extends
{
    public static class FiltersDicExtends
    {
        /// <summary>
        /// 将筛选条件转为查询参数
        /// </summary>
        /// <typeparam name="TEntity">查询条件类型</typeparam>
        /// <param name="entity">查询条件</param>
        /// <returns></returns>
        public static string ToQueryParameters<TEntity>(this TEntity entity) where TEntity : class
        {
            if (entity == null) return "";

            var dicParameters = DicToQueryParameters(entity).Select(x => $"{x.Key}={x.Value}");

            return string.Join("&", dicParameters);
        }

        /// <summary>
        /// 将筛选条件转为查询参数
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string, object>> DicToQueryParameters<TEntity>(TEntity entity) where TEntity : class
        {
            var dic = new List<KeyValuePair<string, object>>();
            var type = entity.GetType();
            var propInfos = type.GetProperties();
            foreach (var propertyInfo in propInfos)
            {
                string propName = propertyInfo.Name;

                if (string.IsNullOrEmpty(propName))
                {
                    continue;
                }

                if (!propertyInfo.IsDefined(typeof(JsonPropertyAttribute), false)) continue;
                JsonPropertyAttribute attribute = (JsonPropertyAttribute)propertyInfo.GetCustomAttribute(typeof(JsonPropertyAttribute), false);

                propName = attribute != null ? attribute.PropertyName : propertyInfo.Name;

                var value = propertyInfo.GetValue(entity);

                if(value == null) continue;

                var valueType = value.GetType();

                //时间类型转为时间戳
                if (valueType == typeof(DateTime?) || valueType == typeof(DateTime))
                {
                    DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                    long timeStamp = (long)((DateTime)value - startTime).TotalSeconds;
                    dic.Add(new KeyValuePair<string, object>(propName,timeStamp));
                }
                else
                {
                    dic.Add(new KeyValuePair<string, object>(propName,value));
                }
            }

            return dic;
        }
    }
}
