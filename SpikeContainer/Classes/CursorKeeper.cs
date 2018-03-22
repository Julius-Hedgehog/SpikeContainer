using System;
using System.Windows.Forms;

namespace PFCS.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class CursorKeeper : IDisposable
    {
        private readonly Cursor _originalCursor;

        private bool _isDisposed;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCursor"></param>
        public CursorKeeper(Cursor newCursor)
        {
            _originalCursor = Cursor.Current;

            Cursor.Current = newCursor;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    Cursor.Current = _originalCursor;
                }
            }
            _isDisposed = true;
        }
    }
}
