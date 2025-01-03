using System.Runtime.Serialization.Formatters.Binary;

namespace _00File
{
    [Serializable]
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        [NonSerialized]
        private string _Password = "abc@123";

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

    }

    internal class Program {
        static void Main(string[] args) {
            string path = "C:\\Users\\Ganesh\\Desktop\\New folder\\new.txt";

            FileStream fileStream = null;

            if (File.Exists(path))
            {
                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            }

            //StreamWriter writer = new StreamWriter(fileStream);
            //writer.WriteLine("content appended...!");
            //writer.Close();

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            Emp emp = new Emp();
            emp.No = 0;
            emp.Name = "Prathamesh";
            emp.Address = "Bagani";

            binaryFormatter.Serialize(fileStream, emp);

            binaryFormatter = null;
            fileStream.Close();
        }
    }
}