# Threading Basics (.NET 8) – Examples and Explanations

This project demonstrates the usage of various threading and synchronization primitives in C#. Each example is implemented in a dedicated class, showing how to coordinate and control access to shared resources in multithreaded scenarios.

---

## Table of Contents

- [ManualResetEventExample.cs](#manualreseteventexamplecs)
- [AutoResetEventExample.cs](#autoreseteventexamplecs)
- [SemaphoreSlimExample.cs](#semaphoreslimexamplecs)
- [SemaphoreExample.cs](#semaphoreexamplecs)
- [MutexExample.cs](#mutexexamplecs)
- [LockExample.cs](#lockexamplecs)
- [MonitorExample.cs](#monitorexamplecs)
- [WorkSimulator.cs](#worksimulatorcs)
- [Program.cs](#programcs)

---

## ManualResetEventExample.cs

**Purpose:**  
Demonstrates the use of `ManualResetEvent` for thread synchronization.  
**How it works:**  
- Starts 3 threads, each waiting on a `ManualResetEvent`.
- After a delay, the main thread signals the event, allowing all waiting threads to proceed at once.
- Useful for scenarios where multiple threads need to wait for a single signal.

---

## AutoResetEventExample.cs

**Purpose:**  
Demonstrates the use of `AutoResetEvent` for thread synchronization.  
**How it works:**  
- Starts multiple threads, each waiting on an `AutoResetEvent`.
- The event is signaled one at a time, allowing only one waiting thread to proceed per signal.
- Useful for sequential thread release.

---

## SemaphoreSlimExample.cs

**Purpose:**  
Shows how to use `SemaphoreSlim` to limit concurrent access to a resource.  
**How it works:**  
- Starts 10 threads, each trying to enter a critical section.
- Only a limited number (default: 3) can enter at the same time.
- Threads wait if the limit is reached, and proceed when a slot is released.

---

## SemaphoreExample.cs

**Purpose:**  
Demonstrates the classic `Semaphore` for controlling access to a resource pool.  
**How it works:**  
- Similar to `SemaphoreSlimExample`, but uses the `Semaphore` class.
- 10 threads compete for 3 available slots.
- Each thread waits, enters the critical section, and releases the semaphore when done.

---

## MutexExample.cs

**Purpose:**  
Illustrates the use of `Mutex` for exclusive access to a critical section.  
**How it works:**  
- Starts 5 threads, each waiting to acquire the mutex.
- Only one thread can enter the critical section at a time.
- Ensures mutual exclusion, even across processes (if needed).

---

## LockExample.cs

**Purpose:**  
Shows the use of the `lock` statement (syntactic sugar for `Monitor`) for thread safety.  
**How it works:**  
- 5 threads attempt to enter a critical section protected by a lock.
- Only one thread can execute the locked code at a time.
- Simplifies mutual exclusion within a single process.

---

## MonitorExample.cs

**Purpose:**  
Demonstrates explicit use of `Monitor.Enter` and `Monitor.Exit` for synchronization.  
**How it works:**  
- 5 threads try to enter a critical section guarded by a monitor.
- Manual control over entering and exiting the monitor.
- Useful for advanced scenarios where you need more control than `lock` provides.

---

## WorkSimulator.cs

**Purpose:**  
Utility class to simulate work by sleeping the current thread.  
**How it works:**  
- Provides a static method to pause execution for a specified duration.
- Used in all examples to mimic time-consuming operations.

---

## How to Run

1. Open the solution in Visual Studio 2022.
2. Build the project (targets .NET 8).
3. Run the application.  
4. Use the console menu to select and observe each threading example.

---