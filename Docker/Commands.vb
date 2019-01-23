﻿

Imports Docker.Captures
''' <summary>
''' Docker commands
''' </summary>
Public Module Commands

    ' PS C:\Users\lipidsearch> docker

    ' Usage:  docker [OPTIONS] COMMAND

    '   A self-sufficient runtime for containers

    ' Options:
    '   --config string          Location of client config files (default "C:\\Users\\lipidsearch\\.docker")
    '   -D, --debug              Enable debug mode
    '   -H, --host list          Daemon socket(s) to connect to
    '   -l, --log-level string   Set the logging level ("debug"|"info"|"warn"|"error"|"fatal") (default "info")
    '   --tls                    Use TLS; implied by --tlsverify
    '   --tlscacert string       Trust certs signed only by this CA (default "C:\\Users\\lipidsearch\\.docker\\ca.pem")
    '   --tlscert string         Path to TLS certificate file (default "C:\\Users\\lipidsearch\\.docker\\cert.pem")
    '   --tlskey string          Path to TLS key file (default "C:\\Users\\lipidsearch\\.docker\\key.pem")
    '   --tlsverify              Use TLS and verify the remote
    '   -v, --version            Print version information and quit

    ' Management Commands:
    '   builder     Manage builds
    '   config      Manage Docker configs
    '   container   Manage containers
    '   image       Manage images
    '   network     Manage networks
    '   node        Manage Swarm nodes
    '   plugin      Manage plugins
    '   secret      Manage Docker secrets
    '   service     Manage services
    '   stack       Manage Docker stacks
    '   swarm       Manage Swarm
    '   system      Manage Docker
    '   trust       Manage trust on Docker images
    '   volume      Manage volumes

    ' Commands:
    '   attach      Attach local standard input, output, and error streams to a running container
    '   build       Build an image from a Dockerfile
    '   commit      Create a new image from a container's changes
    '   cp          Copy files/folders between a container and the local filesystem
    '   create      Create a new container
    '   diff        Inspect changes to files or directories on a container's filesystem
    '   events      Get real time events from the server
    '   exec        Run a command in a running container
    '   export      Export a container's filesystem as a tar archive
    '   history     Show the history of an image
    '   images      List images
    '   import      Import the contents from a tarball to create a filesystem image
    '   info        Display system-wide information
    '   inspect     Return low-level information on Docker objects
    '   kill        Kill one or more running containers
    '   load        Load an image from a tar archive or STDIN
    '   login       Log in to a Docker registry
    '   logout      Log out from a Docker registry
    '   logs        Fetch the logs of a container
    '   pause       Pause all processes within one or more containers
    '   port        List port mappings or a specific mapping for the container
    '   ps          List containers
    '   pull        Pull an image or a repository from a registry
    '   push        Push an image or a repository to a registry
    '   rename      Rename a container
    '   restart     Restart one or more containers
    '   rm          Remove one or more containers
    '   rmi         Remove one or more images
    '   run         Run a command in a new container
    '   save        Save one or more images to a tar archive (streamed to STDOUT by default)
    '   search      Search the Docker Hub for images
    '   start       Start one or more stopped containers
    '   stats       Display a live stream of container(s) resource usage statistics
    '   stop        Stop one or more running containers
    '   tag         Create a tag TARGET_IMAGE that refers to SOURCE_IMAGE
    '   top         Display the running processes of a container
    '   unpause     Unpause all processes within one or more containers
    '   update      Update configuration of one or more containers
    '   version     Show the Docker version information
    '   wait        Block until one or more containers stop, then print their exit codes

    ' Run 'docker COMMAND --help' for more information on a command.

    ReadOnly powershell As New PowerShell

    ''' <summary>
    ''' Search the Docker Hub for images
    ''' </summary>
    ''' <param name="term"></param>
    ''' <returns></returns>
    Public Function Search(term As String) As IEnumerable(Of Search)
        Return powershell($"docker search {term}") _
            .ParseTable(Function(tokens)
                            Return New Search With {
                                .NAME = Image.ParseEntry(tokens(0)),
                                .DESCRIPTION = tokens(1).Trim,
                                .STARS = tokens(2).Trim,
                                .OFFICIAL = tokens(3).Trim,
                                .AUTOMATED = tokens(4).Trim
                            }
                        End Function)
    End Function

    ''' <summary>
    ''' List containers
    ''' </summary>
    ''' <returns></returns>
    Public Function PS() As IEnumerable(Of Container)
        Return powershell("docker ps") _
            .ParseTable(Function(tokens)
                            Return New Container With {
                                .CONTAINER_ID = tokens(0).Trim,
                                .IMAGE = Image.ParseEntry(tokens(1)),
                                .COMMAND = tokens(2).Trim,
                                .CREATED = tokens(3).Trim,
                                .STATUS = tokens(4).Trim,
                                .PORTS = tokens(5),
                                .NAMES = tokens(6).Trim
                            }
                        End Function)
    End Function
End Module
