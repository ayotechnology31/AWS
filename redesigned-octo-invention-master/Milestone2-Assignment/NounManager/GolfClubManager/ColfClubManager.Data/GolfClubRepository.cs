using GolfClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolfClubManager.Data
{
	public class GolfClubRepository 
	{
		private List<GolfClub> golfClubs;

		public GolfClubRepository()
		{
			golfClubs = new List<GolfClub>();
		}
		public void Create(GolfClub gcr)
		{
			golfClubs.Add(gcr);
		}

		public List<GolfClub> ReadAll() 
		{
			//how do i read from my list
			return golfClubs;
		}

		public GolfClub ReadById(int id)
		{
			GolfClub retval = new GolfClub();

			foreach(var club in golfClubs)
			{
				if(club.Id == id)
				{
					retval = club;
					break;
				}
			}
			return retval;
		}
		
		public void Update(int id, GolfClub gc)
		{
			foreach(var club in golfClubs)
			{
				if(club.Id == id)
				{
					club.Id = gc.Id;
					club.Name = gc.Name;
					club.Year = gc.Year;
					club.Rating = gc.Rating;
					break;
				}
			}
		}
		
		public void Delete(int id)
		{
			List<GolfClub> golfClubsCopy = new List<GolfClub>();
			foreach(GolfClub gc in golfClubs)
			{
				if(gc.Id == id) 
				{
					continue;
				}
				golfClubsCopy.Add(gc);
			}
			golfClubs = golfClubsCopy;
		}

	}
}
