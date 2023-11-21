using System.Diagnostics;

namespace Game_Forest
{
    public class Timer
    {
        Stopwatch sw = Stopwatch.StartNew();
        TimeSpan time;
        private int seconds = 1;
        //public Timer(double minutes)
        //{
        //    this.time = TimeSpan.FromMinutes(minutes);
        //    seconds = time.Seconds;
        //}
        public int TimeTick()
        {
            time = TimeSpan.FromMinutes(seconds) -  sw.Elapsed;
            seconds = time.Seconds;

            while (seconds > 0)
            {
                time = TimeSpan.FromMinutes(seconds) - sw.Elapsed;
                seconds = time.Seconds;

                Draw(seconds);
            }

            return seconds;
        }

        public bool TimeIsOver()
        {
            if (seconds <= 0)
                return false;
            else
                return true;
        }

        public void Draw(int seconds)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write($"Timer: {seconds}");
        }
    }
}
