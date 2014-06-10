microsoft-odata-client
======================

Fork of Microsoft's OData Client

In the current version of the official client there is no support for the $search operator.
I created a quick workaround to allow the user to call `AddQueryOptions("$search", "hello world")` and work as expected.
