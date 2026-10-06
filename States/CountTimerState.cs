namespace ApprentissageKana.States
{
    public class CountTimerState
    {
        private System.Timers.Timer horloge;
        private TimeSpan tempsEcoule;
        public bool isRunning = false;
        public event Action? OnChange;

        public void DemarrerChrono ()
        {
            isRunning = true;
            tempsEcoule = TimeSpan.Zero;
            horloge = new System.Timers.Timer(1000);
            horloge.Elapsed += IntervalEcoule;
            horloge.AutoReset = true;
            horloge.Start();
            NotifyStateChanged();
        }

        public void ArreterChrono ()
        {
            isRunning = false;
            horloge.Stop();
            NotifyStateChanged();
        }

        public void IntervalEcoule (object? sender, System.Timers.ElapsedEventArgs e)
        {
            tempsEcoule = tempsEcoule.Add(TimeSpan.FromSeconds(1));
            NotifyStateChanged();
        }

        public string AfficherTemps ()
        {
            return tempsEcoule.ToString(@"mm\:ss");
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
        public void Dispose() => horloge?.Dispose();
    }
}
