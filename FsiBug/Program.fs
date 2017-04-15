namespace Main

module Eventing =
  open PerfectShuffle.EventSourcing
  open PerfectShuffle.EventSourcing.Store
  
  let credentials = Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("","")
        
  // Commenting out this line fixes the issue
  let foo = new PerfectShuffle.EventSourcing.AzureTableStorage.AzureTableStorage.AzureTableDataProvider(credentials, "") :> IStreamDataProvider

module Start =
  
  [<EntryPoint>]
  let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
