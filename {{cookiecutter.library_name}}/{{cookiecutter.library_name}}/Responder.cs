using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.library_name}}
{
	public class Responder
	{
		public Responder()
		{
			_schema = new Schema
			{
				Query = new Types.Query(_data),
				Mutation = new Types.Mutation(_data)
			};
		}

		public string Respond(string request)
		{
			return _schema.Execute(_ => _.Query = request);
		}

		private ISchema _schema;
		private Models.Data _data = new Models.Data();
	}
}
