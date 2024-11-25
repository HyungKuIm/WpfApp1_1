using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Input;
using WpfApp1.ViewModel.Commands;

namespace WpfApp1.ViewModel
{
    public class AvengersViewModel : BaseViewModel
    {
        private string videoSource;
        private bool isPlaying;
        public event EventHandler PlayRequested;

        public string VideoSource
        {
            get => videoSource;
            set
            {
                if (videoSource != value)
                {
                    videoSource = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsPlaying
        {
            get => isPlaying;
            set
            {
                if (isPlaying != value)
                {
                    isPlaying = value;
                    NotifyPropertyChanged();
                    //if (isPlaying)
                    //{
                    //    if (this.PlayRequested != null)
                    //    {
                    //        this.PlayRequested(this, EventArgs.Empty);
                    //    }
                    //}
                }
            }
        }

        public ICommand PlayCommand
        {
            get { return new ActionCommand(action => Play(action)); }
        }

        private bool CanExecutePlay()
        {
            return IsPlaying;
        }

        private void Play(object action)
        {
            IsPlaying = false;
            var title = action as string;
            if (title != null)
            {
                //MessageBox.Show(title);
                switch (title)
                {
                    case "어둠":
                        VideoSource = "doomsday.mp4";

                        break;
                    case "캡아":
                        VideoSource = "braveNW.mp4";
                        break;
                    case "형":
                        VideoSource = "quantum.mp4";
                        break;
                }
                IsPlaying = true;

                if (this.PlayRequested != null)
                {
                    this.PlayRequested(this, EventArgs.Empty);
                }
            }
        }
    }
}
