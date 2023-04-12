## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Bolillas: List~int~
        +Jugar(List~int~)
        +SacarBolilla() int
        +MeterBolillas() int
        +JugarNVeces(List~int~)
    }
    class IJugada{
        <<interface>>
        +NumeroAlAzar: int
        +ElegirBolilla(List~int~)
    }
    class JugadaRandom{
        +NumeroAlAzar() int
        +ElegirBolilla() int
    }
    Bolillero --> IJugada
    JugadaRandom --|> IJugada

    
```