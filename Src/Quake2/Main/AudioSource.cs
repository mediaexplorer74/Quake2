﻿using Microsoft.Xna.Framework.Audio;
using System;

namespace Quake2
{
    public class AudioSource
    {
        private int SampleRate = 48000;
        private DynamicSoundEffectInstance DSEI;
        private byte[] Buffer;
        private int BufferSize;
        private int TotalTime = 0;
        static Random Rand = new Random();

        public AudioSource()
        {
            DSEI = new DynamicSoundEffectInstance(SampleRate, AudioChannels.Mono);
            BufferSize = DSEI.GetSampleSizeInBytes(TimeSpan.FromMilliseconds(500));
            Buffer = new byte[BufferSize];
            DSEI.Volume = 0.4f;
            DSEI.IsLooped = false;
        }

        public void PlayWave(double freq, short durMS, WaveType Wt, float Volume)
        {
            DSEI.Stop();

            BufferSize = DSEI.GetSampleSizeInBytes(TimeSpan.FromMilliseconds(durMS));
            Buffer = new byte[BufferSize];

            int size = BufferSize - 1;
            for (int i = 0; i < size; i += 2)
            {
                double time = (double)TotalTime / (double)SampleRate;

                short currentSample = 0;
                switch (Wt)
                {
                    case WaveType.Sin:
                        {
                            currentSample = (short)(Math.Sin(2 * Math.PI * freq * time) * (double)short.MaxValue * Volume);
                            break;
                        }
                    case WaveType.Tan:
                        {
                            currentSample = (short)(Math.Tan(2 * Math.PI * freq * time) * (double)short.MaxValue * Volume);
                            break;
                        }
                    case WaveType.Square:
                        {
                            currentSample = (short)(Math.Sign(Math.Sin(2 * Math.PI * freq * time)) * (double)short.MaxValue * Volume);
                            break;
                        }
                    case WaveType.Noise:
                        {
                            currentSample = (short)(Rand.Next(-short.MaxValue, short.MaxValue) * Volume);
                            break;
                        }
                }

                Buffer[i] = (byte)(currentSample & 0xFF);
                Buffer[i + 1] = (byte)(currentSample >> 8);
                TotalTime += 2;
            }

            DSEI.SubmitBuffer(Buffer);
            DSEI.Play();
        }
    }
}