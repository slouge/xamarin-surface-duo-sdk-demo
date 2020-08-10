using Xamarin.Forms;
using Xamarin.Forms.DualScreen;

namespace DualScreenDemo.ViewModels
{
    public class ExtendedCanvasViewModel : DualScreenViewModelBase
    {
        private GridLength _hindgeBoundWidth;
        private GridLength _columnWidth = new GridLength(1, GridUnitType.Star);

        internal override void OnSpanModeChanged()
        {
            base.OnSpanModeChanged();

            if(IsSpanned)
            {
                ColumnWidth = new GridLength(DualScreenInfo.Current.SpanningBounds[0].Width / 2);
            }
            else
            {
                
                ColumnWidth = new GridLength(1, GridUnitType.Star);
            }

            HindgeBoundWidth = new GridLength(DualScreenInfo.Current.HingeBounds.Width);
        }

        public GridLength HindgeBoundWidth
        {
            get
            {
                return _hindgeBoundWidth;
            }

            private set
            {
                Set(ref _hindgeBoundWidth, value);
            }
        }

        public GridLength ColumnWidth
        {
            get
            {
                return _columnWidth;
            }

            private set
            {
                Set(ref _columnWidth, value);
            }
        }
    }
}
