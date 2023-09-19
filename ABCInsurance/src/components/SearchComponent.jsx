import React, { useEffect, useState } from 'react';


const SearchComponent = ({setSearchResult}) => {
  const [uniqueId,setUniqueId]=useState('');
  


  const handleSearch = async () => {
    const results = await searchDatabase(uniqueId);
    setSearchResult(results);

  };

  
  const handleInputChange = (e) => {
    setUniqueId(e.target.value);
  };

  
  const searchDatabase = async (id) => {
    try {

      //Evide api ede get with id
      const response = await fetch(`https://localhost:7087/api/web/${id}`);
      if (!response.ok) {
        throw new Error('Network response was not ok');
      }else{
        
      }

      const data = await response.json();
      console.log(data)
      return data;
    } catch (error) {
      throw error;
    }
  };


  return (
    <div className='searchContainer'>
    <p>Memeber Id:</p>
      <input
        type="text"
        placeholder="Enter"
        className='search-bar'
        value={uniqueId}
        onChange={handleInputChange}
      />
      <button className='btn' onClick={handleSearch}>Show</button>
      

    </div>
  );
};

export default SearchComponent;
