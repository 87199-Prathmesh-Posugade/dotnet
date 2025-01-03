using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class Emp {
		private int _age;

		public int age
		{
			get { return _age; }
			set { _age = value; }
		}
	}
}
