## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Cantidad: int
        +Bolillas: List~int~ int
        +Jugar(List~int~) bool
        +JugarNVeces (List~int~) int
        +SacarBolilla() int
        +MeterBolillas() int
    }
    class IAzar{
        <<interface>>
        +IndiceAleatorio(List~int~): int
    }
    class AzarRandom{
        +IndiceAleatorio(List~int~): int
    }
    Bolillero --> IAzar
    AzarRandom --|> IAzar

    
```