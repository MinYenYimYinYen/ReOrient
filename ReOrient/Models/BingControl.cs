using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReOrient.Models
{
	public class BingControl
	{
		public static string BingKey;
		public static Location getBingLocation(Record record, MatchCode minimumMatchCode, Confidence minimumConfidence)
		{

			Location fuckThis = new Location();
			string geocodeRequest = "http://dev.virtualearth.net/REST/v1/Locations/" + record.Address + ", " + record.MarkCust.zip.Trim().Substring(0,5) + "?o=xml&key=" + "Atu4AQp2CNh0a2jeTlH3PwPWtCV-DyjxvTL2f4k2COQmV6407he4vlP2aJw9fZju";
			XmlDocument geocodeResponse = GetXmlResponse(geocodeRequest);
			if (geocodeResponse == null) return null;
		//	geocodeResponse.Save("tempXML.xml");

			Confidence confidenceResult = Confidence.High;
			MatchCode matchCodeResult = MatchCode.Good;
			foreach (XmlNode node in geocodeResponse)
				if (node.Name == "Response")
					foreach (XmlNode node2 in node.ChildNodes)
						if (node2.Name == "ResourceSets")
							foreach (XmlNode node3 in node2.ChildNodes)
								if (node3.Name == "ResourceSet")
									foreach (XmlNode node4 in node3.ChildNodes)
										if (node4.Name == "Resources")
											foreach (XmlNode node5 in node4.ChildNodes)
												if (node5.Name == "Location")
												{
													foreach (XmlNode ConfidenceNode in node5.ChildNodes)
														if (ConfidenceNode.Name == "Confidence")
														{
															confidenceResult = (Confidence)Enum.Parse(typeof(Confidence), ConfidenceNode.InnerText);
														}
													foreach (XmlNode MatchCodeNode in node5.ChildNodes)
														if (MatchCodeNode.Name == "MatchCode")
														{
															switch ((MatchCode)Enum.Parse(typeof(MatchCode), MatchCodeNode.InnerText))
															{
																case MatchCode.Ambiguous:
																	matchCodeResult = MatchCode.Ambiguous;
																	break;
																case MatchCode.UpHierarchy:
																	if (matchCodeResult != MatchCode.Ambiguous) matchCodeResult = MatchCode.UpHierarchy;
																	break;
																case MatchCode.Good:
																	if (matchCodeResult != MatchCode.Ambiguous && matchCodeResult != MatchCode.UpHierarchy) matchCodeResult = MatchCode.Good;
																	break;
															}
														}
													if (matchCodeResult >= minimumMatchCode && confidenceResult >= minimumConfidence)
													{
														foreach (XmlNode node6 in node5.ChildNodes)
															if (node6.Name == "Point")
																foreach (XmlNode bingo in node6.ChildNodes)
																{
																	if (bingo.Name == "Latitude")
																	{
																		fuckThis.Latitude = Convert.ToDouble(bingo.InnerText);
																	}
																	if (bingo.Name == "Longitude")
																	{
																		fuckThis.Longitude = Convert.ToDouble(bingo.InnerText);
																	}

																}
														return fuckThis;
													}
												}





			return null;
		}

		//public static Address getBingAddress(Customer cust)
		//{
		//	Address fuckThis = new Address();
		//	string geocodeRequest = "http://dev.virtualearth.net/REST/v1/Locations/" + cust.ServiceAddress.AddressLine + ", " + cust.ZipCode + "?o=xml&key=" + "Atu4AQp2CNh0a2jeTlH3PwPWtCV-DyjxvTL2f4k2COQmV6407he4vlP2aJw9fZju";
		//	XmlDocument geocodeResponse = GetXmlResponse(geocodeRequest);
		//	if (geocodeResponse == null) return null;




		//	return fuckThis;
		//}




		private static XmlDocument GetXmlResponse(string requestUrl)
		{
			try
			{
				//System.Diagnostics.Trace.WriteLine("Request URL (XML): " + requestUrl);
				HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
				using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
				{
					if (response.StatusCode != HttpStatusCode.OK)
						throw new Exception(String.Format("Server error (HTTP {0}: {1}).",
						response.StatusCode,
						response.StatusDescription));
					XmlDocument xmlDoc = new XmlDocument();
					xmlDoc.Load(response.GetResponseStream());
					return xmlDoc;
				}
			}
			catch (Exception)
			{

				return null;
			}

		}
		public enum Confidence
		{
			Low, Medium, High
		}
		public enum MatchCode
		{
			Ambiguous, UpHierarchy, Good
		}

	}
}
