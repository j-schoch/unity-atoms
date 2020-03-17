using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Interface for all Atom Collection.
    /// </summary>
    public interface IWithCollectionEvents
    {
        AtomBaseVariableEvent Added { get; set; }
        AtomBaseVariableEvent Removed { get; set; }
        VoidEvent Cleared { get; set; }
    }
}