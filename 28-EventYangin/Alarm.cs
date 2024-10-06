using System;
namespace _28_EventYangin
{
	public delegate void EventDelegate(object sender);
	public class Alarm
	{
		public event EventDelegate AlarmCaldi;

		public void AlarmCal(object alarmitetikleyen)
		{
			if (alarmitetikleyen is Kablo)
			{
				Console.WriteLine("Kablodan dolayi Alarm Caldi..");
				AlarmCaldi(this);
			}
			else if (alarmitetikleyen is Sigara)
			{
                Console.WriteLine("Sigara yandi ancak alarm calmadi..");
				return;
            }

		}


		
	}

    
}

