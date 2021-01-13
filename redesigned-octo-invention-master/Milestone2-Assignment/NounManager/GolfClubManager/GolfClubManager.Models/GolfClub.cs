using System;
using System.Collections.Generic;
using System.Text;

namespace GolfClubManager.Models
{
	public class GolfClub
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
		public float Rating { get; set; }
	}
}
