# wslctl

Yet another WSL command line utility for developers

## Development Dependencies

**.NET 5 with .NET Framework 4.7 SDK**

Note: In the latest version of Windows, the .NET Framework is the environment that users can use by default without installing any components, and create the smallest size binary files, so I used a combination of the above techniques. But I may change the project type to the latest version of .NET Core later.

## Roadmap

I am going to implement the following commands one by one. The commands below are arbitrarily conceived, and the actual operation method may change at any time.

```
wslctl start <instance-name>

wslctl shell <instance-name> <command>

wslctl copy <source-instance-name>:<filename> <target-instance-name>:<filename>

wslctl list [--json] [--online]

wslctl clone <source-instance-name> <target-instance-name>

wslctl stop

wslctl delete

wslctl backup <instance-name> <target-gzip-path>

wslctl restore <target-gzip-path> <instance-name> [<install-path>]

wslctl config <instance-name> --default-user=...

wslctl install <distro-type-name> --default-user=...

wslctl mount <instance-name> <linux-path> <windows-path>

wslctl mount list

wslctl unmount <windows-path>
```
