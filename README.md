# QuantumReturn

During comfy drive back from Baltic sea with [Noweli](https://github.com/Noweli) on the wheel, I fell asleep and dreamt about [Particle Swarm Optimization](https://en.wikipedia.org/wiki/Particle_swarm_optimization) algorithm being done using [quantum computing](https://en.wikipedia.org/wiki/Quantum_computing), so this is what it is.

## Problem definition

[Particle Swarm Optimization (PSO)](https://en.wikipedia.org/wiki/Particle_swarm_optimization) is a problem space extremum finding algorithm that is limited by constant dimensionality and probability _(explanation missing)_. From my experience it is exceptionally proficient at finding good-enough solutions in very short time span, making it good investment for finding _entry point_ solutions that can be further optimized by more advanced (but expensive) algorithms.

Based on the idea that PSO search space is limited in constant dimensionality we can assume with marginal certainty that it is great candidate for quantum algorithm.

## Meta problem definition

Considering how my limited knowledge about quantum concepts can quickly cripple ability to deliver anything of value, my focus turns on developing [efficient enough] [Evolutionary Algorithm](https://en.wikipedia.org/wiki/Evolutionary_algorithm) that will produce working artifact containing Q# code ready to be evaluated using [Microsoft Q# Runtime Simulation](https://github.com/microsoft/qsharp-runtime). When this project will reach promising maturity, then produced artifacts could be evaluated on [Azure Quantum](https://azure.microsoft.com/en-gb/products/quantum/) infrastructure.