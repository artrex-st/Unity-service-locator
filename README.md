
# Unity Service Locator

---
<details>
<summary> English (en-US)</summary>

This Unity project demonstrates an implementation of the "Service Locator" pattern to manage scene transitions and debugging functionalities. The Service Locator acts as a central registrar for services, allowing game components to access services without direct knowledge of their implementations. The code is designed for testing purposes and showcases the use of the Service Locator to handle the transition between two scenes and print the name of the active scene.

## Key Components

- **ServiceLocator**: A singleton class that maintains a dictionary of registered services and provides methods to register and retrieve services based on their types. This enables services to be accessed in a decoupled manner, which is useful for future project expansions.

- **ISceneService and SceneService**: An interface that defines methods for loading scenes and printing the scene's name. The `SceneService` class implements this interface and provides real functionality for the scenes. In this project, two instances of the `SceneService` class are created, one for each scene, to demonstrate the use of the Service Locator with different service implementations.

- **Controller**: A MonoBehaviour that manages Unity UI buttons and user interactions. It uses the Service Locator to obtain an instance of `ISceneService`, which is used to load scenes and print the name of the active scene.

## Features

- The "_loadSceneBtn_" button is associated with the `LoadSceneClickHandler` method, which uses the `ISceneService` to load a scene based on the provided name.

- The "_debugBtn_" is linked to the `DebugClickHandler` method, which utilizes the `ISceneService` to print the name of the active scene to the console.

- The `ServiceLocator` allows the `Controller` to obtain an instance of `ISceneService` in a decoupled manner, making it easy to switch or extend services in the future.

## Testing the Service Locator

This project serves as a simple example of how the Service Locator can be used to manage services in a Unity environment. Two scenes (scene1 and scene2) share the same `ISceneService` interface but with different implementations. This demonstrates the flexibility of the Service Locator in allowing different service implementations to be easily used.
</details>

---

<details>
<summary>Português (pt-Br)</summary>

Este projeto Unity demonstra uma implementação do padrão "Service Locator" para gerenciar transições de cena e funcionalidades de depuração. O Service Locator atua como um registrador central para serviços, permitindo que componentes do jogo acessem serviços sem ter conhecimento direto de suas implementações. O código é projetado com o propósito de teste e demonstra o uso do Service Locator para lidar com a transição entre duas cenas e imprimir o nome da cena ativa.

## Componentes-Chave

- **ServiceLocator**: Uma classe singleton que mantém um dicionário de serviços registrados e fornece métodos para registrar e recuperar serviços com base em seus tipos. Isso permite que os serviços sejam acessados de maneira desacoplada, o que é útil para futuras expansões do projeto.

- **ISceneService e SceneService**: Uma interface que define métodos para carregar cenas e imprimir o nome da cena. A classe `SceneService` implementa esta interface e fornece funcionalidade real para as cenas. Neste projeto, duas instâncias da classe `SceneService` são criadas, uma para cada cena, para demonstrar o uso do Service Locator com diferentes implementações de serviços.

- **Controller**: Um MonoBehaviour que gerencia os botões do Unity UI e as interações do usuário. Ele usa o Service Locator para obter uma instância de `ISceneService`, que é usada para carregar cenas e imprimir o nome da cena ativa.

## Funcionalidades

- O botão "_loadSceneBtn_" é associado ao método `LoadSceneClickHandler`, que utiliza o `ISceneService` para carregar uma cena com base no nome fornecido.

- O botão "_debugBtn_" está vinculado ao método `DebugClickHandler`, que usa o `ISceneService` para imprimir o nome da cena ativa no console.

- O `ServiceLocator` permite que o `Controller` obtenha uma instância do `ISceneService` de maneira desacoplada, facilitando a troca ou extensão dos serviços no futuro.

## Teste do Service Locator

Este projeto é um exemplo simples de como o Service Locator pode ser usado para gerenciar serviços em um ambiente Unity. Duas cenas (scene1 e scene2) compartilham a mesma interface `ISceneService`, mas com implementações diferentes. Isso demonstra a flexibilidade do Service Locator ao permitir que diferentes implementações de serviço sejam usadas com facilidade.
</details>
