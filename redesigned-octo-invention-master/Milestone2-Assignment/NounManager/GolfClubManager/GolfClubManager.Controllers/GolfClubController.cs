using System;
using System.Collections.Generic;
using System.Text;
using GolfClubManager.Models;
using GolfClubManager.View;
using GolfClubManager.Data;

namespace GolfClubManager.Controllers
{
	public class GolfClubController
	{
		GolfClubView gv = new GolfClubView();
		GolfClubRepository gr = new GolfClubRepository();

		public void Run()
		{
			int t = 0;

			while(true)
			{

				t = gv.GetMenuChoice();
				if(t == 1)
				{
					CreateGolfClub();
				}
				else if (t == 2)
				{
					ListAllGolfClubs();
				}
				else if (t== 3)
				{
					FindByIDGolfClub();
				}
				else if (t == 4)
				{
					EditGolfClub();
				}
				else if (t == 5)
				{
					RemoveGolfClub();
				}
				else if (t == 0)
				{
					Environment.Exit(0);
				}
			}
		}
		
		private void CreateGolfClub()
		{
			GolfClub gcc = gv.GetNewGolfClubInfo();
			gr.Create(gcc);
		}
		private void ListAllGolfClubs()
		{
			var clubs = gr.ReadAll();
			gv.DisplayAllGolfClubs(clubs);
		}

		private void FindByIDGolfClub()
		{
			// ask for id 
			int id = gv.GetGolfClubId();
			// display for matching id 
			GolfClub club = gr.ReadById(id);
			gv.DisplayGolfClub(club);
		}

		private void EditGolfClub()
		{
			//ask for aid and store it in line 73
			int id = gv.GetGolfClubId();
			//take club and send to line 75
			GolfClub club = gr.ReadById(id);
			//hold updated golfclubinfo
			club = gv.GetUpdatedGolfClubInfo(club);
			//then store the golfclubinfo
			gr.Update(id, club);

		}

		private void RemoveGolfClub()
		{
			int id = gv.ConfirmRemoveGolfClub(null);
			gr.Delete(id);
		}
	}
}
