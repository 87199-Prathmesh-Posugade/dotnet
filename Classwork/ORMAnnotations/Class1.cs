namespace ORMAnnotations
{
	public class Table : Attribute {
		private string _tablename;

		public string name
		{
			get { return _tablename; }
			set { _tablename = value; }
		}
	}

	public class Column : Attribute {
		private string _column;
		private string _datatype;

		public string datatype
		{
			get { return _datatype; }
			set { _datatype = value; }
		}

		public string name
		{
			get { return _column; }
			set { _column = value; }
		}

	}
}
