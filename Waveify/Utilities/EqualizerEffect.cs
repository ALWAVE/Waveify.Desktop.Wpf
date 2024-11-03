using NAudio.Dsp;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waveify.Utilities
{
    public class EqualizerEffect : ISampleProvider
    {
        private readonly ISampleProvider sourceProvider;
        private readonly BiQuadFilter[] filters;

        public EqualizerEffect(ISampleProvider sourceProvider, float lowGain, float midGain, float highGain)
        {
            this.sourceProvider = sourceProvider;

            WaveFormat = sourceProvider.WaveFormat;

            // Инициализация фильтров для низких, средних и высоких частот
            filters = new BiQuadFilter[3];
            filters[0] = BiQuadFilter.LowShelf(WaveFormat.SampleRate, 100f, 0.7f, lowGain);   // Низкие частоты
            filters[1] = BiQuadFilter.PeakingEQ(WaveFormat.SampleRate, 1000f, 0.7f, midGain); // Средние частоты
            filters[2] = BiQuadFilter.HighShelf(WaveFormat.SampleRate, 10000f, 0.7f, highGain); // Высокие частоты
        }

        public WaveFormat WaveFormat { get; }

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = sourceProvider.Read(buffer, offset, count);

            // Применение фильтров к каждому семплу
            for (int n = 0; n < samplesRead; n++)
            {
                buffer[n + offset] = filters[0].Transform(buffer[n + offset]); // Низкие частоты
                buffer[n + offset] = filters[1].Transform(buffer[n + offset]); // Средние частоты
                buffer[n + offset] = filters[2].Transform(buffer[n + offset]); // Высокие частоты
            }

            return samplesRead;
        }
    }
}
