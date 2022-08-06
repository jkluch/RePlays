using System;
using System.Runtime.InteropServices;

namespace obs_net {
    using signal_handler_t = IntPtr;
    using calldata_t = IntPtr;

    public partial class Obs {
        public static void vec2_set(ref vec2 dst, float x, float y){
            dst.x = x;
            dst.y = y;
        }
    }
}
