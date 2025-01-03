using ORMAnnotations;
namespace POCO
{
    [Table(name = "customer")]
    public class Customer
    {
        private string _name;
        private string _mobno;

        [Column(name = "mobile_no", datatype = "CHAR(10)")]

        public string mobno
        {
            get { return _mobno; }
            set { _mobno = value; }
        }


        [Column(name = "customer_name", datatype = "VARCHAR(50)")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

    }

    [Table(name = "emp")]
    public class Employee
    {
        private int _id;

        private string _name;

        private string _email;

        [Column(name = "email", datatype = "VARCHAR(100)")]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        [Column(name = "emp_name", datatype = "VARCHAR(255)")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Column(name = "emp_id", datatype = "INT")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
