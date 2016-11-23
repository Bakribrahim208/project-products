using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace adel_saboor_project
{
    public class Products : workTable, Basic_opertion
    {
        private string _Prod_Id;
        private string _Prod_name;
        private string _Prod_desc;
        private string _coutry_origine;
        private string _ProdStatues;
        private int _quantity;
        private double _price;
        private int _wantary_perioud;

        public string Prod_Id
        {
            get
            {
                return _Prod_Id;
            }
            set
            {
                _Prod_Id = value;
            }
        }

        public string Prod_name
        {
            get
            {
                return _Prod_name;
            }
            set
            {
                _Prod_name = value;
            }
        }

        public string Prod_desc
        {
            get
            {
                return _Prod_desc;
            }
            set
            {
                _Prod_desc = value;
            }
        }

        public string coutry_origine
        {
            get
            {
                return _coutry_origine;
            }
            set
            {
                _coutry_origine = value;
            }
        }

        public string ProdStatues
        {
            get
            {
                return _ProdStatues;
            }
            set
            {
                _ProdStatues = value;
            }
        }

        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int wantary_perioud
        {
            get
            {
                return _wantary_perioud;
            }
            set
            {
                _wantary_perioud = value;
            }
        }

        /// <summary>
        /// هترجعلي عدد الطلبات االشراء التي  بيع فيها هذا المنتحج
        /// </summary>
        public int countOFOrder(string Prouduct_ID)
        {
            throw new System.NotImplementedException();
        }

        public DataRow Max_wanarnty()
        {
            throw new System.NotImplementedException();
        }

        public DataRow Min_waranty()
        {
            throw new System.NotImplementedException();
        }

        public DataRow Max_price()
        {
            throw new System.NotImplementedException();
        }

        public DataRow Min_price()
        {
            throw new System.NotImplementedException();
        }

        public DataTable Disticnt_CountryOrgine()
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
