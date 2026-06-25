public class Solution {
    public uint ReverseBits(uint n) {
        // Start with the input value
        uint ret = n;

        // Swap half-words (16-bit blocks)
        ret = (ret >> 16) | (ret << 16);

        // Swap bytes within each half-word
        ret = ((ret & 0xff00ff00) >> 8) | ((ret & 0x00ff00ff) << 8);

        // Swap 4-bit nibbles within each byte
        ret = ((ret & 0xf0f0f0f0) >> 4) | ((ret & 0x0f0f0f0f) << 4);

        // Swap pairs of bits within each nibble
        ret = ((ret & 0xcccccccc) >> 2) | ((ret & 0x33333333) << 2);

        // Swap individual adjacent bits
        ret = ((ret & 0xaaaaaaaa) >> 1) | ((ret & 0x55555555) << 1);

        return ret;
    }
}
