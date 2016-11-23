using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace adel_saboor_project
{
    public class Customor : workTable, Basic_opertion
         
    {
        private string _cust_ID;
        private string _Cust_name;
        private string _address;
        private string _phone;
        private string  _Gender;
        private orders _orderes;
        public string cust_ID
        {
            get
            {
                return _cust_ID;

            }
            set
            {
                _cust_ID = value;
            }
        }

        public string Cust_name
        {
            get
            {
                return _Cust_name;
            }
            set
            {
                _Cust_name = value;
            }
        }

        public string address
        {
            get
            {

                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public string phone
        {
            get
            {
                return _phone;

            }
            set
            {
                _phone = value;
            }
        }

        public string Gender
        {
            get
            {
                return _Gender;

            }
            set
            {
                _Gender = value;
            }
        }

        public orders orders
        {
            get
            {
                return _orderes;
            }
            set
            {
                _orderes = value;
            }
        }
        protected override void setData()
        {
            _cust_ID = DT.Rows[postion][0].ToString();
            _Cust_name = DT.Rows[postion][1].ToString();
            _address = DT.Rows[postion][2].ToString();
            _phone = DT.Rows[postion][4].ToString();
            _Gender = DT.Rows[postion][3].ToString();
            
        }
        public DataTable ALLData()
        {
            string sel = "select * from CUSTMOR ";
          DT=Runquary(sel);
          return DT;
        }


        /// <summary>
        /// برجع كل الطلبات اللي عميل معين طالبها
        /// </summary>
        public DataTable ALLOrderes(string custmor_ID)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// برجع حاله الطلب سواء تحت التنفييذ او الغي او انتهي والخ كل ده لعميل معين
        /// </summary>
        public DataTable Order_states(string custmor_ID, Request_statues states)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// برجع قيمه الطلبات اللي عميل طلبها
        /// </summary>
        public double Order_value(string custmor_ID)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// برجع قيمه الطلبات اللي العميل بطلبها ولكن ع حسب حاله  الطلب
        /// </summary>
        public double orderValueStates(string custmor_ID, string states)
        {
            throw new System.NotImplementedException();
        }

        public    string  Add_new()
        {
            string ins = "insert into CUSTMOR values('" + cust_ID + "','" + Cust_name + "','" + address + "','" + Gender + "','" + phone + "')";
            if (RunDml(ins) == "OK")
            {
                return "custmor added successfully";
            }
            else
                return "custmor not added please change custmor id ";
        }

        public string Delete()
        {
            string del = "Delete from  CUSTMOR where CUS_ID='" + cust_ID + "'  ";
            if (RunDml(del) == "OK")
            {
                return "custmor Deleted successfully";
            }
            else
                return "custmor Data not Deleted ,please check realted Data ";
        }

        public string Update()
        {
            string del = "update data set CUS_NAME='" + Cust_name + "',ADDRESS='" + address + "',GENDER='" + Gender + "',PHONE='" + phone + "' where CUS_ID='" + cust_ID + "' ";
            if (RunDml(del) == "OK")
            {
                return "custmor UPdated successfully";
            }
            else
                return "custmor Data not updated ,please check realted Data ";
        }
        
    }
}
