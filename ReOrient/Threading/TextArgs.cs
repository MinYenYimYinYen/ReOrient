using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Threading
{	
	public class TextArgs : EventArgs
	{
		public TextArgs(string textMessage)
		{
			message = textMessage;
		}

		private string message;
		public string Message
		{
			get
			{
				return message;
			}
			set
			{
				message = value;
			}
		}
	}
}
