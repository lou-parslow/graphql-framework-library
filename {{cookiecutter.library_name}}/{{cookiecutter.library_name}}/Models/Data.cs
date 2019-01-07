using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.library_name}}.Models
{
	public class Data
	{
		public Dictionary<string, Base64Data> Base64Data { get; } = new Dictionary<string, Base64Data>();
	}
}
