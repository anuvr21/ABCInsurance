import logo from './logo.svg';
import './App.css';
import SearchComponent from './components/SearchComponent';
import { useEffect, useState } from 'react';
import Member from './components/Member';
import Pharmacy from './components/Pharmacy';



function App() {

  const [searchResult,setSearchResult]=useState(null);



  return (

    <div className="App">
<SearchComponent setSearchResult={setSearchResult}/>
{searchResult ? (
          <div>
            <Member searchResults={searchResult} setSearchResult={setSearchResult} />
            <Pharmacy searchResults={searchResult} />
          </div>
        ) : null}
    </div>
  
  );
}

export default App;
