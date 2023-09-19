import React,{useEffect,useState} from 'react';


const TableComponent = ({searchResults}) => {

 
  return (
    <table className="custom-table">
      <thead>
        <tr>
          <th className="table-heading">Date</th>
          <th className="table-heading">Quantity</th>
          <th className="table-heading">Provider Full Name</th>
          <th className="table-heading">Specialty Code</th>
        </tr>
      </thead>
      <tbody>
      {searchResults.map((result) => (
  <tr key={result.member.memberUniquePersonKey+result.date}>
    <td>{result.date}</td>
    <td>{result.quantity}</td>
    <td>{result.providerFullName}</td>
    <td>{result.specialtyCode}</td>
  </tr>
))}

      </tbody>
    </table>
  );
};

export default TableComponent;
