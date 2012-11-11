﻿namespace FsUnit.Test
open NUnit.Framework
open FsUnit
open FsUnitDepricated

[<TestFixture>]
type ``be lessThanOrEqualTo tests`` ()=
    [<Test>] member test.
     ``10 should be less than 11`` ()=
        10 |> should be (lessThanOrEqualTo 11)

    [<Test>] member test.
     ``10.0 should be less than 10.1`` ()=
        10.0 |> should be (lessThanOrEqualTo 10.1)

    [<Test>] member test.
     ``10 should not be less than 9`` ()=
        10 |> should not (be lessThanOrEqualTo 9)

    [<Test>] member test.
     ``9.2 should not be less than 9.1`` ()=
        9.2 |> should not (be lessThanOrEqualTo 9.1)

    [<Test>] member test.
     ``9.1 should be less than or equal to 9.1`` ()=
        9.1 |> should be (lessThanOrEqualTo 9.1)
