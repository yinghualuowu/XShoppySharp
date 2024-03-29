﻿namespace XShoppySharp.Entities.Order
{
    /// <summary>
    /// 订单服务返回实体
    /// </summary>
    public class XShoppyOrderResp:XShoppyObject<XShoppyOrderData> { }

    /// <summary>
    /// 订单服务返回列表实体
    /// </summary>
    public class XShoppyOrderListResp : XShoppyObject<XShoppyOrderListData> { }

    /// <summary>
    ///  订单服务返回个数
    /// </summary>
    public class XShoppyOrderCountResp : XShoppyObject<XShoppyOrderCountData> { }

    /// <summary>
    ///  更新部分订单信息
    /// </summary>
    public class XShoppyOrderUpdateResp : XShoppyObject<string> { }
}
