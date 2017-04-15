Possible bug in F# Interactive:

    error FS0193: internal error: Value cannot be null.
    Parameter name: con


To repro, clone repository and run ``bug.bat`` (this just restores dependencies and uses FSI to run ``test.fsx``)

