using System;

namespace RobotName
{
	public class Robot
	{
		private string _name;

		private static string SetName()
		{
			var randomSymbol = new Random();
			const int nameLength = 5;

			var symbols = new char[nameLength];

			for (var i = 0; i < nameLength; i++)
			{
				var lower = '0';
				var upper = '9';
				if (i < 2)
				{
					lower = 'A';
					upper = 'Z';
				}
				var symbol = randomSymbol.Next(lower, upper);
				symbols[i] = (char)symbol;
			}

			return new string(symbols);
		}

		public string Name
		{
			get
			{
				if (!string.IsNullOrEmpty(_name)) return _name;
				_name = SetName();
				return _name;
			}
			set => _name = value;
		}

		public void Reset()
		{
			Name =  SetName();
		}
	}
}