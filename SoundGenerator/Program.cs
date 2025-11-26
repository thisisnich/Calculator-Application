using System;
using System.IO;

class Program
{
    static void Main()
    {
        string soundsDir = @"..\Calculator Application\Sounds";
        Directory.CreateDirectory(soundsDir);
        
        // Create different sound types
        CreateBeepSound(Path.Combine(soundsDir, "ButtonClick_Number.wav"), 800, 50);  // Higher pitch for numbers
        CreateBeepSound(Path.Combine(soundsDir, "ButtonClick_Operator.wav"), 600, 50); // Medium pitch for operators
        CreateBeepSound(Path.Combine(soundsDir, "ButtonClick_Function.wav"), 1000, 50); // Higher pitch for functions
        CreateBeepSound(Path.Combine(soundsDir, "ButtonClick_Utility.wav"), 500, 50);   // Lower pitch for utility
        CreateBeepSound(Path.Combine(soundsDir, "ResultAnnouncement.wav"), 600, 200);   // Longer sound for results
        
        Console.WriteLine("Sound files created in Calculator Application\\Sounds");
    }
    
    static void CreateBeepSound(string filename, int frequency, int durationMs)
    {
        int sampleRate = 44100;
        int samples = (int)(sampleRate * durationMs / 1000.0);
        short[] data = new short[samples];
        
        for (int i = 0; i < samples; i++)
        {
            double t = (double)i / sampleRate;
            // Apply envelope to avoid clicks
            double envelope = i < samples / 10 ? (double)i / (samples / 10) : 
                            i > samples * 9 / 10 ? 1.0 - (double)(i - samples * 9 / 10) / (samples / 10) : 1.0;
            data[i] = (short)(Math.Sin(2 * Math.PI * frequency * t) * 8000 * envelope);
        }
        
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            // WAV header
            writer.Write("RIFF".ToCharArray());
            writer.Write(36 + samples * 2);
            writer.Write("WAVE".ToCharArray());
            writer.Write("fmt ".ToCharArray());
            writer.Write(16); // fmt chunk size
            writer.Write((short)1); // audio format (PCM)
            writer.Write((short)1); // channels (mono)
            writer.Write(sampleRate); // sample rate
            writer.Write(sampleRate * 2); // byte rate
            writer.Write((short)2); // block align
            writer.Write((short)16); // bits per sample
            writer.Write("data".ToCharArray());
            writer.Write(samples * 2);
            
            // Audio data
            foreach (short sample in data)
            {
                writer.Write(sample);
            }
        }
    }
}


