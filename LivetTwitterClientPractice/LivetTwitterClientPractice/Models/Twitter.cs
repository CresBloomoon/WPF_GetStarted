using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivetTwitterClientPractice.Models
{
    internal sealed class Twitter : Model
    {
        private int _TweetCount;

        public int TweetCount
        {
            get { return _TweetCount; }
            set
            {
                if (_TweetCount == value) return;
                _TweetCount = value;
                RaisePropertyChanged();
            }
        }
    }
}
