using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics.EF.Core
{
    public class DataDicCreator
    {
        //private readonly CSSDTenantDbContext _context;
        public List<DataDic> initDics = new List<DataDic>();

        public DataDicCreator()
        {
            initDics.Add(NewDicItem("OrderStatus", "订单状态", 0, "待接单"));
            initDics.Add(NewDicItem("OrderStatus", "订单状态", 1, "已付款"));
            initDics.Add(NewDicItem("OrderStatus", "订单状态", 2, "已接单"));
            initDics.Add(NewDicItem("OrderStatus", "订单状态", 3, "已签收"));

            initDics.Add(NewDicItem("PayMethod", "支付方式", 1, "支付宝"));
            initDics.Add(NewDicItem("PayMethod", "支付方式", 2, "微信"));
            initDics.Add(NewDicItem("PayMethod", "支付方式", 3, "京东支付"));

            initDics.Add(NewDicItem("AccountType", "卡类型", 1, "储蓄卡"));
            initDics.Add(NewDicItem("AccountType", "卡类型", 2, "信用卡"));

            initDics.Add(NewDicItem("BankType", "银行类型", 1, "中国工商银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 2, "中国建设银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 3, "中国农业银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 4, "中国银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 5, "交通银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 6, "中信银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 7, "光大银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 8, "华夏银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 9, "民生银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 10, "招商银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 11, "兴业银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 12, "广发银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 13, "浦发银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 14, "平安银行"));
            initDics.Add(NewDicItem("BankType", "银行类型", 15, "邮政储蓄银行"));
        }
        private DataDic NewDicItem(string typeCode, string typeName, int itemCode, string itemName)
        {
            DataDic data = new DataDic();
            data.TypeCode = typeCode;
            data.TypeName = typeName;
            data.ItemCode = itemCode;
            data.ItemName = itemName;
            return data;
        }
    }
}
