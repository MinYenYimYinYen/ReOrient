using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class Record
	{
		public SA.markcust MarkCust { get; set; }
		public string Address
		{
			get
			{
				var mark = MarkCust;
				StringBuilder str = new StringBuilder();
				str.Append(mark.streetno);
				str.Append(' ');

				if (!string.IsNullOrWhiteSpace(mark.predir))
				{
					str.Append(mark.predir);
					str.Append(' ');
				}
				str.Append(mark.streetnm);
				str.Append(' ');
				str.Append(mark.suffix);


				if (!string.IsNullOrWhiteSpace(mark.postdir))
				{
					str.Append(' ');
					str.Append(mark.postdir);
				}

				return str.ToString();
			}
		}

	}
}
