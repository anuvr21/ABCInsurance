import React from 'react'
import TableComponent from './TableComponent'

const Pharmacy = ({searchResults}) => {


  return (
    <div className='m-container'>  
       <div className='heading'
    >
            <h2>Pharmacy Details</h2>
            <div></div>
            </div>
     <TableComponent searchResults={searchResults} />

            </div>
  )
}

export default Pharmacy