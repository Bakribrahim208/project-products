using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace adel_saboor_project
{
    public class orders : workTable, Basic_opertion
    {
        private string _Order_ID;
        private DateTime _Order_Date;
        private string _OrderStatues;
        private string _custmor_ID;
        private DataTable _Detials;
        private Products _products;
        public string Order_ID
        {
            get
            {
                return _Order_ID;
            }
            set
            {
                _Order_ID = value;
            }
        }

        public System.DateTime Order_Date
        {
            get
            {
                return _Order_Date;
            }
            set
            {
                _Order_Date = value;
            }
        }

        public string OrderStatues
        {
            get
            {
                return _OrderStatues;
            }
            set
            {
                _OrderStatues = value;
            }
        }

        public string custmor_ID
        {
            get
            {
                return _custmor_ID;
            }
            set
            {
                _custmor_ID = value;
            }
        }

        public DataTable Detials
        {
            get
            {
                return _Detials;
            }
            set
            {
                _Detials = value;
            }
        }

        public Products Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }

        /// <summary>
        /// كل تفاصيل الطلب ابعت رقم الطلب وهيرجعلي كل التفاصيل
        /// </summary>
        public DataTable All_Details(string Order_ID)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هبعتله حاله الطلب سواء انتهي ولا تحت التنفيذ الخ وهيرجعلي كل الطلبات بتفاصيلها
        /// </summary>
        public DataTable Order_IN_statues(Request_statues OrderStatues)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هترجعلي اعلي طلب من حيث السعر
        /// </summary>
        public DataRow Max_Order()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هترجعلي اقل طلب من حيث السعر
        /// </summary>
        public DataRow Min_Order()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هترجعلي قيمه الموسطه من حيث السعر للطلبات
        /// </summary>
        public void Average_order()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هبعتليه تاريخين واحد بدايه الفتره والتاني نهايه الفتره وهيرجعلي كل الطلبات اللي حصلت ف الفتره دي
        /// </summary>
        public DataTable Average_between(DateTime start_date, DateTime end_date)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هترجعلي كل المنتجات اللي ف الطلب اللي هبعتله رقمه عن طري الاي يدي
        /// </summary>
        public DataTable All_productsINOrder(string Order_ID)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// هبعتله رقم منتج معين وةهيجيبلي كل الطبات اللي منتج ده دخل فيها
        /// </summary>
        public DataTable Orderes_in_product(string product_ID)
        {
            throw new System.NotImplementedException();
        }

        public string Add_new()
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}
