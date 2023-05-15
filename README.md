# BinaryTree

This code represents a simple implementation of a binary tree data structure. It creates a binary tree from a list of numbers and performs various operations on the tree.

## Prerequisites

- .NET Core SDK [link](https://dotnet.microsoft.com/download)

## Getting Started

To get started with this code, follow these steps:

1. Clone the repository:

   ```shell
   git clone https://github.com/your-username/BinaryTree.git
   ```

2. Open the project in your favorite IDE or text editor.

3. Build the project to restore the dependencies:

   ```shell
   dotnet build
   ```

4. Run the project:

   ```shell
   dotnet run
   ```

## Functionality

The code creates a binary tree from a list of numbers and performs the following operations:

- Finds the minimum value in the tree and displays it.
- Finds the maximum value in the tree and displays it.
- Prints the numbers in the tree in ascending order (in-order traversal).
- Prints the numbers in the tree in descending order (reverse in-order traversal).

## Usage

The code initializes a list of numbers and creates a binary tree using the `Node.CreateTree` method. The tree is then used to perform the operations mentioned above.

The minimum and maximum values in the tree are found using the `FindMin` and `FindMax` methods of the root node. The numbers in the tree are printed in ascending and descending order using the `PrintInOrder` and `PrintInReverseOrder` methods of the root node, respectively.

## Contributing

Contributions to this project are welcome. If you have any suggestions, improvements, or bug fixes, please create a new issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
