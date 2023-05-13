# Networking. 

## Bridge in Dokcer.

Why we need bridge in docker?
- Docker containers are isolated from each other.
- Containers can communicate with each other through the bridge.
- Containers can communicate with the outside world without NAT.
- Containers can be connected to multiple networks.
- Containers should not be able to communicate with Docker daemons running on the host.
- Best practice is to connect each container to a single network.

#### MacVlan networks in Docker.
MacVlan allows you to assign a MAC address to a container, making it appear as a physical device on your network. The Docker daemon routes traffic to containers by their MAC addresses. When Docker sees a packet addressed to a MAC address that is assigned to a container, it delivers it to the container.
<br>
Networking equipment needs to be able to handle `promiscuous mode` for MacVlan to work properly. Promiscuous mode is a setting on a network interface that causes it to receive all traffic on the network, regardless of whether it is addressed to the interface or not. This is required because the Docker daemon forwards all traffic to containers, even if it is not addressed to them.

#### IpvLan networks in Docker.
IpvLan allows you to create a network that looks like a physical network to the containers connected to it. Containers connected to an IpvLan network can communicate with other containers connected to the same network. Containers on different IpvLan networks can not communicate with each other directly. However, you can connect a container on one IpvLan network to a container on another IpvLan network using a bridge.

#### Orcestrator networks in Docker. (Infrastructure as a layer)
Orcestrator networks are created and managed by `Docker Swarm`. When you initialize a swarm or join a Docker host to an existing swarm, two new networks are created on that Docker host:
- an overlay network called `ingress`, which handles control and data traffic related to swarm services. When you create a swarm service and do not connect it to a user-defined overlay network, it connects to the ingress network by default.
- a bridge network called `docker_gwbridge`, which connects the individual Docker daemon to the other daemons participating in the swarm.

#### Docker Swarm
- Docker Swarm is a clustering and scheduling tool for Docker containers. With Swarm, IT administrators and developers can establish and manage a cluster of Docker nodes as a single virtual system. Swarm mode also provides a number of features to improve the resilience of your applications, including rescheduling, rolling updates, and node health checks.
- How swarm works ? 
- Swarm mode uses managers and workers to run your applications. Managers are the only machines in a swarm that can execute your commands, or authorize other machines to join the swarm as workers. Workers are just there to provide capacity and do not have the authority to tell any other machine what it can and cannot do.


Cluster works with Daemons, Managers and Workers.
- Daemons: are the Docker engines that run on each node participating in the swarm. The Docker daemon is responsible for running containers, pulling and pushing images to and from container registries, and managing networks.
- Managers: are responsible for the orchestration and management of the cluster. Managers maintain the desired state of the swarm, and schedule services on worker nodes. Managers also perform the tasks of a worker node.
- Workers: are responsible for running containers. Workers receive and execute tasks dispatched from managers. Workers can also perform the tasks of a manager node.
- Leader: is a manager that is responsible for managing the quorum of the swarm. The leader is the only machine in the swarm that can perform management tasks, such as scheduling services and maintaining the state of the swarm. If the leader becomes unavailable, a new leader is elected from the remaining managers in the swarm. The leader node is the only machine that can write to the raft log. The leader node is also the only machine that can authorize other machines to join the swarm as managers or workers.

