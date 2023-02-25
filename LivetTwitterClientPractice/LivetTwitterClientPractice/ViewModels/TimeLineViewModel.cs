using Livet;
using Livet.EventListeners;
using LivetTwitterClientPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LivetTwitterClientPractice.ViewModels
{
    internal sealed class TimeLineViewModel : ViewModel
    {
        Authorizer authorizer = new Authorizer();

        Twitter twitter = new Twitter();
        PropertyChangedEventListener listener;

        public void Initialize()
        {
            listener = new PropertyChangedEventListener(twitter)
            {
                () => twitter.TweetCount, (_, __) => RaisePropertyChanged(() => TeetCount)
            };
        }

        public int TweetCount { get { return twitter.TweetCount; } }
        
    }
}
