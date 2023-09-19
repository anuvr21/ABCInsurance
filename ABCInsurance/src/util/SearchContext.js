import React, { createContext, useContext, useState } from 'react';

// Create the SearchContext
const SearchContext = createContext();

export function useSearch() {
  return useContext(SearchContext);
}

export function SearchProvider({ children }) {
  const [searchQuery, setSearchQuery] = useState('');
  const [searchResults, setSearchResults] = useState([]);

  const updateSearchQuery = (query) => {
    setSearchQuery(query);
  };

  const updateSearchResults = (results) => {
    setSearchResults(results);
  };

  return (
    <SearchContext.Provider
      value={{
        searchQuery,
        searchResults,
        updateSearchQuery,
        updateSearchResults,
      }}
    >
      {children}
    </SearchContext.Provider>
  );
}
