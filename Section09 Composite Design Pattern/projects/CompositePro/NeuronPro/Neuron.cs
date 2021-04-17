using System;
using System.Collections;
using System.Collections.Generic;

namespace NeuronPro
{
    //Neuron contains List<Neuron> of In , Out
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;

        private Lazy<List<Neuron>> _out = new Lazy<List<Neuron>>();


        private Lazy<List<Neuron>> _in2 = new Lazy<List<Neuron>>();


        public List<Neuron> In => _in2.Value;
        public List<Neuron> Out => _out.Value;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}
