using System;
namespace Sharpnado.CollectionView.ViewModels
{
    public class DragAndDropEventArgs : EventArgs
    {
        public DragAndDropEventArgs()
        {
        }

        public DragAndDropEventArgs(int from, int to, object content)
        {
            From = from;
            To = to;
            Content = content;
        }

        public int To { get; }

        public int From { get; }

        public object Content { get; }
    }
}
