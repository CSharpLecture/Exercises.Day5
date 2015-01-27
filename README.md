# Exercises.Day5

Exercises and solutions for the fifth day.

## 21. Threads and communication

Implement a multithreaded program. One thread, the worker thread, is doing some time consuming "work" (i.e. counts to infinity) and reports periodically its progress to another thread, the UI thread.

A sample code for the worker thread (without reporting the progress) would be the following:

    //Ping is available in System.Net.NetworkInformation
    Ping ping = new Ping();

    //Replace true with a statement if the loop should continue
    while (true)
    {
        var reply = ping.Send("132.199.99.246");

        //Use information from reply when reporting progress

        //Just wait a bit before making sending again
        Thread.Sleep(1000);
    }

One last thing: Avoid cross-threading exceptions!

## 22. (**MP**) Write a simple math tool

Write a simple math tool that let's users enter numbers in two textboxes. Only integer numbers separated by commas should be allowed. Place all user controls in a `TabControl`.

There should be one `ComboBox` element and one `Button` control. The combobox contains the following strings:

* Intersection
* Union
* Except
* Symmetric Except
* Square
* Square Root
* Sum
* Min
* Max

If the button is pressed a function is called depending on the currently selected item in the combobox. While the first four functions are requiring both sets of numbers (obtained from the two textboxes), the other functions only require one of the sets.

It should be obvious that each function represents a LINQ function. The result of the LINQ operation should be displayed in a new tab (called results) of your form.

## 23. Async / await with C# 5

Compute the following method in an async task and await the result:

    double ComputePi()
    {
    	var sum = 0.0;
        var step = 1e-9;

        for(var i = 0; i &lt; 1000000000; i++)
        {
            var x = (i + 0.5) * step;
            sum = sum + 4.0 / (1.0 + x * x); 
        }

        return sum * step;
    }

Start the computation by presing a button. The button click event handler should then disable the button, await the result of the computation, set the result of the computation in a label and enable the button again.

## 24. The Task Parallel Library

Use the Task Parallel Library to make a parallel version of the method given in exercise 23. Try to avoid race conditions, i.e. synchronize the communication on shared variables. Reduce the required communication where possible and reduce the usage of shared variables to a minimum. Compare executation time and result with the serial implementation.

*Hint* Use `Parallel.For` instead of `for` and take the overload that defines a (thread-)local variable as well.

## License
This work is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).