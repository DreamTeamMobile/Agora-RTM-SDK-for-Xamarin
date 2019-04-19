using System;
using DT.Xamarin.Agora.Rtm;

namespace DT.Samples.Agora.Rtm.Droid
{
    public class RtmClientListener : Java.Lang.Object, IRtmClientListener
    {
        public Action<int, int> StateChanged;
        public Action<RtmMessage, string> MessageReceived;

        public void OnConnectionStateChanged(int state, int reason)
        {
            StateChanged?.Invoke(state, reason);
        }

        public void OnMessageReceived(RtmMessage message, string peerId)
        {
            MessageReceived?.Invoke(message, peerId);
        }
    }
}