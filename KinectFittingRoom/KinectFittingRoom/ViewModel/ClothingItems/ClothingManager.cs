﻿using System.Collections.ObjectModel;
using KinectFittingRoom.ViewModel.ButtonItems;

namespace KinectFittingRoom.ViewModel.ClothingItems
{
    public class ClothingManager : ViewModelBase
    {
        #region Private Fields
        /// <summary>
        /// The chosen clothing collection
        /// </summary>
        private ObservableCollection<ClothingItemBase> _chosenClothes;
        /// <summary>
        /// The clothing collection
        /// </summary>
        private ObservableCollection<ClothingButtonViewModel> _clothing;
        #endregion Private Fields
        #region Public Properties
        /// <summary>
        /// Gets or sets the chosen clothing collection.
        /// </summary>
        /// <value>
        /// The chosen clothing collection.
        /// </value>
        public ObservableCollection<ClothingItemBase> ChosenClothes
        {
            get { return _chosenClothes; }
            set
            {
                if (_chosenClothes == value)
                    return;
                _chosenClothes = value;
                OnPropertyChanged("ChosenClothes");
            }
        }
        /// <summary>
        /// Gets or sets the available clothing collection.
        /// </summary>
        /// <value>
        /// The available clothing collection.
        /// </value>
        public ObservableCollection<ClothingButtonViewModel> Clothing
        {
            get { return _clothing; }
            set
            {
                if (_clothing == value)
                    return;
                _clothing = value;
                OnPropertyChanged("Clothing");
            }
        }
        #endregion Public Properties
    }
}
