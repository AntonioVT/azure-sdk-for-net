// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Class  representing the video&apos;s rate control. </summary>
    public partial class RateControl
    {
        /// <summary> Initializes a new instance of RateControl. </summary>
        public RateControl()
        {
        }

        /// <summary> Initializes a new instance of RateControl. </summary>
        /// <param name="bitRateLimit"> the maximum output bitrate in kbps. </param>
        /// <param name="encodingInterval"> Interval at which images are encoded and transmitted. </param>
        /// <param name="frameRateLimit"> Maximum output framerate in fps. </param>
        /// <param name="guaranteedFrameRate"> A value of true indicates that frame rate is a fixed value rather than an upper limit, and that the video encoder shall prioritize frame rate over all other adaptable configuration values such as bitrate. </param>
        internal RateControl(float? bitRateLimit, float? encodingInterval, float? frameRateLimit, bool? guaranteedFrameRate)
        {
            BitRateLimit = bitRateLimit;
            EncodingInterval = encodingInterval;
            FrameRateLimit = frameRateLimit;
            GuaranteedFrameRate = guaranteedFrameRate;
        }

        /// <summary> the maximum output bitrate in kbps. </summary>
        public float? BitRateLimit { get; set; }
        /// <summary> Interval at which images are encoded and transmitted. </summary>
        public float? EncodingInterval { get; set; }
        /// <summary> Maximum output framerate in fps. </summary>
        public float? FrameRateLimit { get; set; }
        /// <summary> A value of true indicates that frame rate is a fixed value rather than an upper limit, and that the video encoder shall prioritize frame rate over all other adaptable configuration values such as bitrate. </summary>
        public bool? GuaranteedFrameRate { get; set; }
    }
}
