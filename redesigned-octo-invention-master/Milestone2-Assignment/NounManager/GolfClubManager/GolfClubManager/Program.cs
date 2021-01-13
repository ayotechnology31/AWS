using System;
using GolfClubManager.Controllers;

namespace GolfClubManager
{
	class Program
	{
		static void Main(string[] args)
		{
			GolfClubManager.Controllers.GolfClubController gc = new GolfClubController();
			gc.Run();
		}
	}
}
