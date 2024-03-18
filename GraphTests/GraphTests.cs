using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedArchitect_CoChi.Tests.GraphTests
{
    public class GraphTests
    {
        [Fact]
        public void TestCountConnectedComponents()
        {
            // Arrange
            var graph = new Graph(7);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(5, 6);
            graph.AddEdge(6, 7);
            graph.AddEdge(5, 7);

            // Act
            var result = graph.CountConnectedComponents();

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestCountConnectedComponents_WithAllVerticesConnected()
        {
            // Arrange
            var graph = new Graph(4);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            // Act
            var result = graph.CountConnectedComponents();

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestCountConnectedComponents_WithNoEdges()
        {
            // Arrange
            var graph = new Graph(5);

            // Act
            var result = graph.CountConnectedComponents();

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestCountConnectedComponents_WithOneVertex()
        {
            // Arrange
            var graph = new Graph(1);

            // Act
            var result = graph.CountConnectedComponents();

            // Assert
            Assert.Equal(1, result);
        }
    }
}
