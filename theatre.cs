using System;

namespace Theatre
{
	class Theatre
	{
		static void Main(String[] args)
		{ 
			int a ;
			a = seatsInTheater(16,11,5,3);
		}

		static int seatsInTheater(int nCols, int nRows, int col, int row)
		{
			int nSeats;
			var Lcol=nCols-(col-1);
			var Lrow=nRows-row;

			return nSeats=Lrow*Lcol;

		}

	}
}