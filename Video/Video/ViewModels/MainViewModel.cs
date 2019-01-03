using System;
using System.Collections.Generic;
using System.Text;

namespace Video.ViewModels
{
    class MainViewModel
    {
        #region ViewModel
        public VideoViewModel VideoP { get; set; }

        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.VideoP = new VideoViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
